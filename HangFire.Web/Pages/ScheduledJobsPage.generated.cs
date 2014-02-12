﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\ScheduledJobsPage.cshtml"
    using Common;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\ScheduledJobsPage.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\ScheduledJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ScheduledJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");






            
            #line 6 "..\..\Pages\ScheduledJobsPage.cshtml"
  
    Layout = new LayoutPage { Title = "Scheduled Jobs" };

    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.Current.Monitoring.ScheduledCount())
    {
        BasePageUrl = Request.LinkTo("/scheduled")
    };

    var scheduledJobs = JobStorage.Current.Monitoring.ScheduledJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 22 "..\..\Pages\ScheduledJobsPage.cshtml"
 if (pager.TotalPageCount == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        There are no scheduled jobs.\r\n    </d" +
"iv>\r\n");


            
            #line 27 "..\..\Pages\ScheduledJobsPage.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 30 "..\..\Pages\ScheduledJobsPage.cshtml"
Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
            
            #line 30 "..\..\Pages\ScheduledJobsPage.cshtml"
                                              
    

            
            #line default
            #line hidden
WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th" +
">Id</th>\r\n                <th>Enqueue</th>\r\n                <th>Job type</th>\r\n " +
"               <th></th>\r\n            </tr>\r\n        </thead>\r\n");


            
            #line 41 "..\..\Pages\ScheduledJobsPage.cshtml"
         foreach (var job in scheduledJobs)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr class=\"");


            
            #line 43 "..\..\Pages\ScheduledJobsPage.cshtml"
                   Write(!job.Value.InScheduledState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                <td>\r\n                    <a href=\"");


            
            #line 45 "..\..\Pages\ScheduledJobsPage.cshtml"
                        Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        ");


            
            #line 46 "..\..\Pages\ScheduledJobsPage.cshtml"
                   Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </a>\r\n");


            
            #line 48 "..\..\Pages\ScheduledJobsPage.cshtml"
                     if (!job.Value.InScheduledState)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span title=\"Job\'s state has been changed while fetching " +
"data.\" class=\"glyphicon glyphicon-question-sign\"></span>\r\n");


            
            #line 51 "..\..\Pages\ScheduledJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td data-moment=\"");


            
            #line 53 "..\..\Pages\ScheduledJobsPage.cshtml"
                            Write(JobHelper.ToStringTimestamp(job.Value.ScheduledAt));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 53 "..\..\Pages\ScheduledJobsPage.cshtml"
                                                                                 Write(job.Value.ScheduledAt);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>\r\n                    ");


            
            #line 55 "..\..\Pages\ScheduledJobsPage.cshtml"
               Write(HtmlHelper.QueueLabel(job.Value.Method));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span title=\"");


            
            #line 56 "..\..\Pages\ScheduledJobsPage.cshtml"
                            Write(HtmlHelper.DisplayMethodHint(job.Value.Method));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                        ");


            
            #line 57 "..\..\Pages\ScheduledJobsPage.cshtml"
                   Write(HtmlHelper.DisplayMethod(job.Value.Method));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                </td>\r\n                <td>\r\n");


            
            #line 61 "..\..\Pages\ScheduledJobsPage.cshtml"
                     if (job.Value.InScheduledState)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"btn btn-default btn-sm\" data-ajax=\"");


            
            #line 63 "..\..\Pages\ScheduledJobsPage.cshtml"
                                                                     Write(Request.LinkTo("/schedule/enqueue/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\" data-loading-text=\"Enqueueing...\">\r\n                            <span class=\"gl" +
"yphicon glyphicon-play\"></span>\r\n                            Enqueue now\r\n      " +
"                  </button>\r\n");


            
            #line 67 "..\..\Pages\ScheduledJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n");


            
            #line 70 "..\..\Pages\ScheduledJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");


            
            #line 72 "..\..\Pages\ScheduledJobsPage.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 73 "..\..\Pages\ScheduledJobsPage.cshtml"
Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 73 "..\..\Pages\ScheduledJobsPage.cshtml"
                                        
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
