﻿using System;

namespace XeroApi.Model
{
    public class Journal : EndpointModelBase
    {

        [ItemId]
        public Guid JournalID { get; set; }

        public DateTime JournalDate { get; set; }

        public long JournalNumber { get; set; }

        [ItemUpdatedDate]
        public DateTime CreatedDateUTC { get; set; }

        public string Reference { get; set; }

        public JournalLines JournalLines { get; set; }

        public Guid SourceID { get; set; }

        public string SourceType { get; set; }

        public override string ToString()
        {
            return string.Format("Journal:{0}", JournalNumber);
        }
    }
    

    public class Journals : ModelList<Journal>
    {
    }
}
