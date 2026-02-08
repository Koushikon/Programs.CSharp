
using Thread_1;

Multithreadingv1 mt_1 = new();
Multithreadingv2 mt_2 = new();
Multithreadingv3 mt_3 = new();
Multithreadingv4 mt_4 = new();
Multithreadingv5 mt_5 = new();
Multithreadingv6 mt_6 = new();

mt_1.ExecuteCode();
mt_2.UsingLock_ExecuteCode();
mt_3.UsingInterlocked_ExecuteCode();
mt_4.UsingMonitor_ExecuteCode();
// mt_5.UsingMonitorWaitTime_ExecuteCode();
mt_6.UsingMutex_ExecuteCode();


Console.WriteLine("End of world.");