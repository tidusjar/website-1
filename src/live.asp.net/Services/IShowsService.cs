﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using live.asp.net.Models;

namespace live.asp.net.Services
{
    public interface IShowsService
    {
        Task<ShowList> GetRecordedShowsAsync(ClaimsPrincipal user, bool disableCache, bool useDesignData);
    }
}