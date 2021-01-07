using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoYo.Application.DTOs;

namespace YoYo.Application.Interfaces.Repositories
{
    public interface ILogRepository
    {
        Task<List<AuditLogResponse>> GetAuditLogsAsync(string userId);

        Task AddLogAsync(string action, string userId);
    }
}
