﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YoYo.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit(CancellationToken cancellationToken);

        Task Rollback();
    }
}
