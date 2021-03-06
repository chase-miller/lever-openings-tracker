﻿using System;

namespace OpeningsTracker.Core.Models
{
    public class JobPosting
    {
        public string Text { get; set; }
        public string Id { set; get; }
        public string DepartmentTeamGroup { get; set; }
        public DateTime? CreatedAtDTime { get; set; }
        public string HostedUrl { get; set; }
        public string SourceSystemId { get; set; }
        public string ShortDescription { get; set; }
    }
}
