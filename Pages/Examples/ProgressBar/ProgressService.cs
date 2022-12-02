using System;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorExamples.Pages.Examples.ProgressBar;

public class ProgressService : IDisposable
{
    public EventHandler<double> ProgressBarUpdated;
    
    private double _progress = 0.0;
    private PeriodicTimer _timer;

    public async Task Start()
    {
        _timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

        while (await _timer.WaitForNextTickAsync())
        {
            if (_progress < 100)
            {
                _progress += 1;
                ProgressBarUpdated(this, _progress);
            }
        }
    }

    public Task Stop()
    {
        _timer?.Dispose();
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _timer?.Dispose();
    }
}