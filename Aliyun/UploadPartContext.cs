﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Aliyun.OSS;

namespace TransferLib.Aliyun
{
    public class UploadPartContext
    {
        public string BucketName { get; set; }
        public string ObjectName { get; set; }

        public List<PartETag> PartETags { get; set; }

        public string UploadId { get; set; }
        public long TotalParts { get; set; }
        public long CompletedParts { get; set; }
        public object SyncLock { get; set; }
        public ManualResetEvent ManualEvent { get; set; }
    }
}