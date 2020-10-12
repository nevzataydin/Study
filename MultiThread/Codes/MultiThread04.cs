using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThread.Codes
{
    class MultiThread04
    {
		/*
		 Thread.Join 
	 Blocks current thread and makes it wait until the thread on which join method is invoked completes.
	 Join method has an overload that allow us to to specify the timeout.

 Thread.IsAlive
	 Returns true if thread still processing

 How to protect shared resources from concurrent access
	 Interlocked.Increment(ref variable);
	 Or
	 static object _lock = new object();
	 lock (_lock) {variable++;}
	 lock locks all threads except current one. So it is not performent

 Interlock
	 C# is not thread safe.  
	 works only for int, long, double and float

 Lock
	 Restricts the critical region, so that only one thread can enter that area in one time.
	 Lock needs an object to continue its operation. 
	 It applies a lock on a target object and only one thread can lock that target object at a time.

 Monitor
	 Lock is just a shortcut for Monitor statement. 
	 Compiler internally converts lock statement to Monitor.Enter and Exit statements.
	 Enter
	 Exit
	 TryEnter
	 Pulse: notifies a waiting thread of a change in the locked object's state
	 Wait: releases the current acquired lock and blocks the current thread until it reacquires the lock
	 static object _lock = new object();
	 Monitor.Enter(_lock);
	 try{Total++;}
	 finally{Monitor.Exit(_lock);}

		 */
	}
}
