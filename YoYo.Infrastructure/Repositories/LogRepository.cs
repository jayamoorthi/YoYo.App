﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoYo.Application.Interfaces.Repositories;

namespace YoYo.Infrastructure.Repositories
{
    //public class LogRepository : ILogRepository
    //{
    //    private readonly IMapper _mapper;
    //    private readonly IRepositoryAsync<Audit> _repository;

    //    public LogRepository(IRepositoryAsync<Audit> repository, IMapper mapper)
    //    {
    //        _repository = repository;
    //        _mapper = mapper;
    //        _dateTimeService = dateTimeService;
    //    }

    //    public async Task AddLogAsync(string action, string userId)
    //    {
    //        var audit = new Audit()
    //        {
    //            Type = action,
    //            UserId = userId,
    //            DateTime = _dateTimeService.NowUtc
    //        };
    //        await _repository.AddAsync(audit);
    //    }

    //    public async Task<List<AuditLogResponse>> GetAuditLogsAsync(string userId)
    //    {
    //        var logs = await _repository.Entities.Where(a => a.UserId == userId).OrderByDescending(a => a.Id).Take(250).ToListAsync();
    //        var mappedLogs = _mapper.Map<List<AuditLogResponse>>(logs);
    //        return mappedLogs;
    //    }
    //}

    //public class LogProfile : Profile
    //{
    //    public LogProfile()
    //    {
    //        CreateMap<AuditLogResponse, Audit>().ReverseMap();
    //    }
    //}
}