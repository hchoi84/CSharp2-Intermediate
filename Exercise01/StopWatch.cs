using System;

namespace Exercise01
{
  public class StopWatch
  {
    private bool _hasStarted = false;
    private DateTime _started;
    private DateTime _stopped;

    public DateTime Started 
    { 
      get { return _started; }
      set 
      { 
        if (_hasStarted)
          throw new InvalidOperationException("Must stop timer before attempting to start");
          
        _started = value; 
        _hasStarted = true;
      }
    }

    public DateTime Stopped 
    { 
      get { return _stopped; }
      set 
      { 
        if (!_hasStarted)
          throw new InvalidOperationException("Must start timer before attempting to end it");

        _stopped = value; 
        _hasStarted = false;
      }
    }

    public TimeSpan Duration
    {
      get { return (_stopped - _started); }
    }
  }
}