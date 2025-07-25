﻿using Microsoft.Extensions.Logging;

namespace SportChallenge.Logger;

public class FileLoggerProvider : ILoggerProvider
{
    private string path;
    public FileLoggerProvider(string _path)
    {
        path = _path;
    }
    public ILogger CreateLogger(string categoryName)
    {
        return new FileLogger(path);
    }

    public void Dispose()
    {
    }
}