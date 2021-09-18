﻿using Lol.Data.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lol.ExampleData.History
{
    public partial class ExamHistory
    {
        public static List<HistoryModel> GetActivitys()
        {
            List<HistoryModel> source = new List<HistoryModel>();

            source.Add(new HistoryModel {ActivePercent = 10, Job = ""});
            source.Add(new HistoryModel {ActivePercent = 55, Job = ""});
            source.Add(new HistoryModel {ActivePercent = 32, Job = ""});
            source.Add(new HistoryModel {ActivePercent = 64, Job = ""});
            source.Add(new HistoryModel {ActivePercent = 22, Job = ""});

            return source;
        }
    }
}
