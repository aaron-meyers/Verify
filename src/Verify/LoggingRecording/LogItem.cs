﻿using System;
using Microsoft.Extensions.Logging;

class LogItem
{
    public LogLevel? Level { get; }
    public string? Category { get; }
    public string Message { get; }
    public EventId EventId { get; }
    public Exception? Exception { get; }

    public LogItem(LogLevel? level, string? category, EventId eventId, Exception? exception, string message)
    {
        Level = level;
        Category = category;
        EventId = eventId;
        Exception = exception;
        Message = message;
    }
}