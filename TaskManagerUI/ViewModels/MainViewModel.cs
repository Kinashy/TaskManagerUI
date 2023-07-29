using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TaskManagerUI.Commands;
using Timer = System.Threading.Timer;

namespace TaskManagerUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        List<string> _detailed = new();
        public List<string> Detailed
        {
            get => _detailed;
            set
            {
                if (value != _detailed)
                {
                    _detailed = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _processName = "None";
        public string ProcessName 
        { 
            get => _processName;
            set
            {
                if (_processName != value)
                {
                    _processName = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _basePriority = -1;
        public int BasePriority
        {
            get => _basePriority;
            set
            {
                if (_basePriority != value)
                {
                    _basePriority = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _workingSet = -1;
        public int WorkingSet
        {
            get => _workingSet;
            set
            {
                if (_workingSet != value)
                {
                    _workingSet = value;
                    OnPropertyChanged();
                }
            }
        }
        private int _id = -1;
        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _procent = 0.0F;
        public float Procent
        {
            get => _procent;
            set
            {
                if (_procent != value)
                {
                    _procent = value;
                    OnPropertyChanged();
                }
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        private Process[] _processes = new Process[0];
        public MainCommand SelectProcess { get; set; }
        private Process _CurrentProcess { get; set; }
        private Process[] _Processes
        {
            get => _processes;
            set
            {
                var inLP = from p in value where ProcessDataTable.AsEnumerable().All(row => row.Field<Int32>("ID") != p.Id) select p;
                var inLPArray = inLP.ToArray();
                foreach (var p in inLPArray)
                {
                    ProcessDataTable.Rows.Add(p.Id);
                }
                var inDT = from row in ProcessDataTable.AsEnumerable() where value.All(p => p.Id != row.Field<Int32>("ID")) select row;
                var inDTArray = inDT.ToArray();
                foreach (var r in inDTArray)
                {
                    ProcessDataTable.Rows.Remove(r);
                }
                _processes = value;
                //ProcessDataTable.AcceptChanges();
                OnPropertyChanged(nameof(ProcessDataTable));
            }
        }
        private PerformanceCounter CurrentPerformanceCounter { get; set; }
        private DataTable _processDataTable = new DataTable();
        public DataTable ProcessDataTable
        { 
            get => _processDataTable;
            set
            {
                if (_processDataTable != value) 
                {
                    _processDataTable = value;
                    OnPropertyChanged();
                }
            }
        }
        private bool _StartEnabled = true;
        public bool StartEnabled 
        { 
            get => _StartEnabled;
            set
            {
                if (_StartEnabled != value)
                {
                    _StartEnabled = value;
                    OnPropertyChanged();
                }
            }
        }
        private string _status = "";
        public string Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged();
                }
            }
        }
        private CancellationTokenSource _cts;
        public MainCommand StartCommand { get; set; }
        public MainCommand StopCommand { get; set; }
        public MainViewModel() // Inicialize of viewmodel
        {
            Status = "idle";
            ProcessDataTable.Columns.Add("ID", Type.GetType("System.Int32")); // Process ID collumn
            StopCommand = new MainCommand // Determine the stop command
                (
                _ =>
                {
                    Status = "idle";
                    Program.Logger.Info("Stop button have pressed.");
                    StopLoop(); // Stop update process list
                    
                    StartEnabled = !StartEnabled;
                    Program.Logger.Info("Stop button is not aviable now.");
                    Program.Logger.Info("Detailed button is not aviable now.");
                    Program.Logger.Info("Start button is aviable now.");
                    _Processes = new Process[0];
                    Id = -1;
                    ProcessName = "None";
                    BasePriority = -1;
                    WorkingSet = -1;
                    Procent = -1;
                    if (_CurrentProcess != null)
                        _CurrentProcess.Dispose();
                    _CurrentProcess = null;
                    if (CurrentPerformanceCounter != null)
                    {
                        CurrentPerformanceCounter.Close();
                        CurrentPerformanceCounter.Dispose();
                    }
                    CurrentPerformanceCounter = null;
                    ProcessDataTable.Clear();
                }
                );
            StartCommand = new MainCommand
            (_ => 
            {
                Status = "Update processes...";
                Program.Logger.Info("Start button have pressed.");
                StartEnabled = !StartEnabled;
                Program.Logger.Info("Detailed button is aviable now.");
                Program.Logger.Info("Stop button is aviable now.");
                Program.Logger.Info("Start button is not aviable now.");
                _Processes = Process.GetProcesses();
                StringBuilder forLoggerInfo = new StringBuilder();
                forLoggerInfo.AppendLine($"ID\tName");
                foreach (var process in _Processes)
                {
                    forLoggerInfo.AppendLine($"{process.Id}\t{process.ProcessName}");
                }
                Program.Logger.Info("Application got list of processes.");
                Program.Logger.Info(forLoggerInfo.ToString());
                forLoggerInfo.Clear();
                forLoggerInfo = null;
                StartLoop();
            }
            );
            SelectProcess = new MainCommand(obj =>
                {
                    try
                    {
                        Program.Logger.Info("Select button have pressed.");
                        var dgv = ((DataGridView)obj);
                        Int32 id = (Int32)dgv.SelectedRows[0].Cells[0].Value;
                        var query = from p in _Processes.AsEnumerable() where id == p.Id select p;
                        foreach (var p in query)
                        {
                            _CurrentProcess = p;
                            break;
                        }
                        if (CurrentPerformanceCounter != null)
                        {
                            CurrentPerformanceCounter.Close();
                            CurrentPerformanceCounter.Dispose();
                        }
                        Status = $"Update processes... Getting info about ID = ${_CurrentProcess.Id}";
                        CurrentPerformanceCounter = new PerformanceCounter("Process", "% Processor Time", _CurrentProcess.ProcessName);
                        Id = _CurrentProcess.Id;
                        ProcessName = _CurrentProcess.ProcessName;
                        BasePriority = _CurrentProcess.BasePriority;
                        WorkingSet = (_CurrentProcess.WorkingSet / 1024);
                        Procent = CurrentPerformanceCounter.NextValue() / Convert.ToSingle(Environment.ProcessorCount);
                        Program.Logger.Info($"Current process: id {_CurrentProcess.Id}, name {_CurrentProcess.ProcessName}, base priority {BasePriority.ToString()}, working set {WorkingSet}, procent {Procent}.");
                    }
                    catch (Exception ex)
                    {
                        Status = "Error: " + ex.Message;
                        Program.Logger.Error(ex);
                        Id = -1;
                        ProcessName = "None";
                        BasePriority = -1;
                        WorkingSet = -1;
                    }
                }
            );
        }
        private async Task RunLoopAsync(CancellationToken token)
        {
            try
            {
                Program.Logger.Info($"Start scanning process in loop thread.");
                while (true)
                {
                    Process[] processes = Process.GetProcesses();
                    //Program.Logger.Info("Processes has got by thread");
                    var oldProcess = processes.IntersectBy(_Processes.Select(x => x.Id), x => x.Id).ToArray();
                    var newProcess = processes.ExceptBy(_Processes.Select(x => x.Id), x => x.Id).ToArray();
                    var deletedProcess = _Processes.ExceptBy(processes.Select(x => x.Id), x => x.Id).ToArray();
                    StringBuilder forLogger = new StringBuilder();
                    //Program.Logger.Info("New process: ");
                    if (newProcess.Length > 0)
                    {
                        forLogger.AppendLine("New processes: ");
                        forLogger.AppendLine("ID\tName");
                        foreach (var process in newProcess)
                        {
                            forLogger.AppendLine($"{process.Id}\t{process.ProcessName}");
                        }
                    }
                    if (deletedProcess.Length > 0)
                    {
                        forLogger.AppendLine("Deleted processes: ");
                        forLogger.AppendLine("ID\tName");
                        foreach (var process in deletedProcess)
                        {
                            forLogger.AppendLine($"{process.Id}\t{process.ProcessName}");
                        }
                    }
                    if (forLogger.Length > 0)
                    {
                        Program.Logger.Info(forLogger);
                    }
                    forLogger.Clear();
                    _Processes = oldProcess.Union(newProcess).ToArray();
                    if ((_CurrentProcess is not null) && (CurrentPerformanceCounter != null))
                    {
                        var query = from p in _Processes.AsEnumerable() where _CurrentProcess.Id == p.Id select p;
                        foreach (var p in query)
                        {
                            _CurrentProcess = p;
                            break;
                        }
                        Id = _CurrentProcess.Id;
                        ProcessName = _CurrentProcess.ProcessName;
                        BasePriority = _CurrentProcess.BasePriority;
                        Procent = CurrentPerformanceCounter.NextValue() / Convert.ToSingle(Environment.ProcessorCount);
                        WorkingSet = _CurrentProcess.WorkingSet / 1024;
                        Program.Logger.Info($"Current process: id {_CurrentProcess.Id}, name {_CurrentProcess.ProcessName}, base priority {BasePriority.ToString()}, working set {WorkingSet}, procent {Procent}.");
                    }
                    await Task.Delay(1000, token); // подождать одну секунду
                }
            }
            catch (OperationCanceledException)
            {
                Status = "idle";
                Program.Logger.Info("Stop thread loop by cancellation token.");
            } // сработала отмена, ничего не делать
        }
        private async void StartLoop()
        {
            if (_cts != null)
            {
                Program.Logger.Error("Thread is working already now.");
                return;
            }
            try
            {
                using (_cts = new CancellationTokenSource())
                {
                    await RunLoopAsync(_cts.Token);
                }
            }
            catch (Exception ex)
            {
                Program.Logger.Error(ex);
            }
            _cts = null;
        }

        private void StopLoop()
        {
            Program.Logger.Info("Stop update process thread");
            _cts?.Cancel();
        }
    }
}