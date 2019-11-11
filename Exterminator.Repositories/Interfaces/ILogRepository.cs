using System.Collections.Generic;
using Exterminator.Models;
using Exterminator.Models.Dtos;
using Exterminator.Models.InputModels;

namespace Exterminator.Repositories.Interfaces
{
    public interface ILogRepository
    {
        void LogToDatabase(ExceptionModel exception);
        // TODO: Should contain a method which retrieves all logs (LogDto)
        // ordered by timestamp (descending)
        IEnumerable<LogDto> GetAllLogs();
    }
}