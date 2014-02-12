﻿using System;

namespace HangFire.Redis
{
    public class RedisStorageOptions
    {
        public RedisStorageOptions()
        {
            JobDequeueTimeOut = TimeSpan.FromSeconds(5);
            PollInterval = TimeSpan.FromSeconds(15);
        }

        public TimeSpan JobDequeueTimeOut { get; set; }
        public TimeSpan PollInterval { get; set; }
    }
}
