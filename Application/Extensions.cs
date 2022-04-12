using Application.Readers;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class Extensions
{
    public static void AddDependencies(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<ICsvReaderFactory, CsvReaderFactory>();
        serviceCollection.AddTransient<ICsvValidationReader, CsvValidationReader>();
        serviceCollection.AddTransient<IRecordReader, HeaderReader>();
        serviceCollection.AddTransient<IRecordReader, DetailReader>();
        serviceCollection.AddTransient<IRecordReader, TrailerReader>();
    }
}