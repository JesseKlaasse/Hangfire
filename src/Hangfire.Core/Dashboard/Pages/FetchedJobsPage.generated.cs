﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    using System;
    
    #line 2 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class FetchedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");








            
            #line 8 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
  
    Layout = new LayoutPage(Queue.ToUpperInvariant());

    int from, perPage;
    var filter = Query("filter");

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    var monitor = Storage.GetMonitoringApi();
    var pager = new Pager(from, perPage, monitor.FetchedCount(Queue, filter), filter, DefaultRecordsPerPage);
    var fetchedJobs = monitor.FetchedJobs(Queue, pager.FromRecord, pager.RecordsPerPage, filter);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-3\">\r\n        ");


            
            #line 24 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
   Write(Html.JobsSidebar());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-9\">\r\n        ");


            
            #line 27 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
   Write(Html.Breadcrumbs(Strings.FetchedJobsPage_Title, new Dictionary<string, string>
        {
            { "Queues", Url.LinkToQueues() },
            { Queue.ToUpperInvariant(), Url.Queue(Queue) }
        }));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <h1 class=\"page-header\">\r\n            ");


            
            #line 34 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
       Write(Queue.ToUpperInvariant());

            
            #line default
            #line hidden
WriteLiteral(" <small>");


            
            #line 34 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                        Write(Strings.FetchedJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n        </h1>\r\n\r\n");


            
            #line 37 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
         if (pager.TotalPageCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"alert alert-info\">\r\n            ");


            
            #line 40 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
       Write(Strings.FetchedJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");


            
            #line 42 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"js-jobs-list\">\r\n            <div class=\"btn-toolbar btn-toolb" +
"ar-top\">\r\n                <button class=\"js-jobs-list-command btn btn-sm btn-pri" +
"mary\"\r\n                        data-url=\"");


            
            #line 48 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                             Write(Url.To("/jobs/enqueued/requeue"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                        data-loading-text=\"");


            
            #line 49 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                      Write(Strings.Common_Enqueueing);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                        disabled=\"disabled\">\r\n                    <span class=" +
"\"glyphicon glyphicon-repeat\"></span>\r\n                    ");


            
            #line 52 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
               Write(Strings.Common_RequeueJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </button>\r\n\r\n                <button class=\"js-jobs-list-comman" +
"d btn btn-sm btn-default\"\r\n                        data-url=\"");


            
            #line 56 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                             Write(Url.To("/jobs/enqueued/delete"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                        data-loading-text=\"");


            
            #line 57 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                      Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                        data-confirm=\"");


            
            #line 58 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                 Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                        disabled=\"disabled\">\r\n                    <span class=" +
"\"glyphicon glyphicon-remove\"></span>\r\n                    ");


            
            #line 61 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
               Write(Strings.Common_DeleteSelected);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </button>\r\n                \r\n");


            
            #line 64 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                 if (EnableJobFilters)
                {
                    
            
            #line default
            #line hidden
            
            #line 66 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
               Write(Html.Filter(pager));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                       
                }

            
            #line default
            #line hidden
WriteLiteral(@"            </div>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th class=""min-width"">
                                <input type=""checkbox"" class=""js-jobs-list-select-all"" />
                            </th>
                            <th class=""min-width"">");


            
            #line 77 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                             Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th class=\"min-width\">");


            
            #line 78 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                             Write(Strings.Common_State);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th>");


            
            #line 79 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                           Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");


            
            #line 80 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                             if (DisplayArgumentsInLists)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <th class=\"min-width\">");


            
            #line 82 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                 Write(Strings.Common_Arguments);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");


            
            #line 83 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                            <th class=\"align-right\">");


            
            #line 84 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                               Write(Strings.Common_Fetched);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n             " +
"       <tbody>\r\n");


            
            #line 88 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                         foreach (var job in fetchedJobs)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr class=\"js-jobs-list-row hover ");


            
            #line 90 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                          Write(job.Value == null ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                <td>\r\n");


            
            #line 92 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                     if (job.Value != null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input type=\"checkbox\" class=\"js-jobs-lis" +
"t-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 94 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                                                                             Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");


            
            #line 95 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                                <td class=" +
"\"min-width\">\r\n                                    ");


            
            #line 98 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                               Write(Html.JobIdLink(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </td>\r\n");


            
            #line 100 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                 if (job.Value == null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <td colspan=\"");


            
            #line 102 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                             Write(DisplayArgumentsInLists ? 4 : 3);

            
            #line default
            #line hidden
WriteLiteral("\"><em>");


            
            #line 102 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                                                    Write(Strings.Common_JobExpired);

            
            #line default
            #line hidden
WriteLiteral("</em></td>\r\n");


            
            #line 103 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <td class=\"min-width\">\r\n                     " +
"                   ");


            
            #line 107 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                   Write(Html.StateLabel(job.Value.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </td>\r\n");



WriteLiteral("                                    <td class=\"word-break\">\r\n                    " +
"                    ");


            
            #line 110 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                   Write(Html.JobNameLink(job.Key, job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </td>\r\n");


            
            #line 112 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 112 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                     if (DisplayArgumentsInLists)
                                     {

            
            #line default
            #line hidden
WriteLiteral("                                         <td class=\"ellipsis ellipsis-wrap\">\r\n   " +
"                                          ");


            
            #line 115 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                        Write(Html.JobArguments(job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                         </td>\r\n");


            
            #line 117 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                     }
            
            #line default
            #line hidden
            
            #line 117 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                      

            
            #line default
            #line hidden
WriteLiteral("                                    <td class=\"align-right\">\r\n");


            
            #line 119 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                         if (job.Value.FetchedAt.HasValue)
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 121 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.Value.FetchedAt.Value));

            
            #line default
            #line hidden
            
            #line 121 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                                                                         
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n");


            
            #line 124 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </tr>\r\n");


            
            #line 126 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n   " +
"         <div class=\"btn-toolbar\">\r\n                ");


            
            #line 132 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
           Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n                \r\n                ");


            
            #line 134 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
           Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </div>\r\n");


            
            #line 137 "..\..\Dashboard\Pages\FetchedJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
