
using Threading_Mutex.Models;

string file = "D:/file1.txt";
ThreadEntity.WriteNumbers_NoMutex(file);

file = "D:/file2.txt";
ThreadEntity.WriteNumbers_Mutex_Improper(file);

file = "D:/file3.txt";
ThreadEntity.WriteNumbers_Mutex(file);