﻿
using Microsoft.Extensions.Logging;
namespace AppBloodWeb.Infrastructure.Logging;

public class CustomLoggerProviderConfiguration
{
    public LogLevel LogLevel { get; set; } = LogLevel.Warning;
    public int EventId { get; set; } = 0;
}
