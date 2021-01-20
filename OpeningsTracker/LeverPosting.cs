﻿using System;

namespace OpeningsTracker
{
    class LeverPosting
    {
        public string Id { get; set; }
        public string HostedUrl { get; set; }
        public string DescriptionPlain { get; set; }
        public long? CreatedAt { get; set; }

        public DateTime? CreatedAtDTime => CreatedAt.HasValue
            ? DateTimeOffset.FromUnixTimeMilliseconds(CreatedAt.Value).DateTime
            : (DateTime?) null;

        public string Text { get; set; }
        public LeverCategory Categories { get; set; }
    }

    class LeverCategory
    {
        public string Commitment { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Team { get; set; }
    }
}