// https://www.enjoysharepoint.com/create-timer-job-in-sharepoint-2016-programmatically/
/* In a SharePoint timer job, we use the SharePoint server object model code. 
So we can not develop a timer job for SharePoint Online.

For SharePoint Online, we have to develop web jobs which is an alternative to timer job in SharePoint Online.
https://www.enjoysharepoint.com/create-azure-webjobs-for-sharepoint-online/
 */
/*Open SharePoint 2016 Central Administration 
 * -> Monitoring -> Then under Timer Jobs click on “Review job definitions”. 
 * This page will display all the default timer jobs in SharePoint.
 */

/*must be in a farm solution*/


// 2) Add a class and paste code below

using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace CustomTimerJob.Features.OurCustomTimerJobFeature
{
	/// <summary>
	/// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
	/// </summary>
	/// <remarks>
	/// The GUID attached to this class may be used during packaging and should not be modified.
	/// </remarks>

	[Guid("f01fcc35-3b30-434a-b43a-fadc69a6fe69")]
	public class OurCustomTimerJobFeatureEventReceiver : SPFeatureReceiver
	{
		const string JobName = "Site Creation Timer";
		// Uncomment the method below to handle the event raised after a feature has been activated.
		public override void FeatureActivated(SPFeatureReceiverProperties properties)
		{
			try
			{
				SPSecurity.RunWithElevatedPrivileges(delegate ()
				{
					SPWebApplication parentWebApp = (SPWebApplication)properties.Feature.Parent;
					SPSite site = properties.Feature.Parent as SPSite;
					DeleteExistingJob(JobName, parentWebApp);
					CreateJob(parentWebApp);
				});
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private bool CreateJob(SPWebApplication site)
		{
			bool jobCreated = false;
			try
			{
				OurCustomTimerJob job = new OurCustomTimerJob(JobName, site);
				SPMinuteSchedule schedule = new SPMinuteSchedule();
				schedule.BeginSecond = 0;
				schedule.EndSecond = 59;
				schedule.Interval = 5;
				job.Schedule = schedule;
				job.Update();
			}
			catch (Exception)
			{
				return jobCreated;
			}
			return jobCreated;
		}

		public bool DeleteExistingJob(string jobName, SPWebApplication site)
		{
			bool jobDeleted = false;
			try
			{
				foreach (SPJobDefinition job in site.JobDefinitions)
				{
					if (job.Name == jobName)
					{
						job.Delete();
						jobDeleted = true;
					}
				}
			}
			catch (Exception)
			{
				return jobDeleted;
			}
			return jobDeleted;
		}

		// Uncomment the method below to handle the event raised before a feature is deactivated.
		public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
		{
			lock (this)
			{
				try
				{
					SPSecurity.RunWithElevatedPrivileges(delegate ()
					{
						SPWebApplication parentWebApp = (SPWebApplication)properties.Feature.Parent;
						DeleteExistingJob(JobName, parentWebApp);
					});
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Uncomment the method below to handle the event raised after a feature has been installed.
		//public override void FeatureInstalled(SPFeatureReceiverProperties properties)
		//{
		//}
		// Uncomment the method below to handle the event raised before a feature is uninstalled.
		//public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
		//{
		//}
		// Uncomment the method below to handle the event raised when a feature is upgrading.
		//public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
		//{
		//}
	}
}



/* 3) Add feature
 * Then right-click on the Features folder and then click on Add Feature. 
 * This will add a custom feature to it. You can rename the feature for an appropriate name.
 * Give a proper Title for your feature. Then set the scope to WebApplication like below:
 * 
 * If you want the feature to be activated by default 
 * then you can change Activate On Default property from False to True like below:
 */


/* 4) Add event receiver to feature 
 Then right-click on the Feature and then click on Add Event Receiver. 
 In the event receiver file, we will add logic to handle the FeatureActivated and FeatureDeactivating method. 
 */


/* 5) Deploying
To deploy a SharePoint timer job, right click on the timer job in visual studio 2015/2017 and then click on Deploy. 
Once it is deployed successfully.

Open SharePoint 2016 central administration, 
then click on Manage web application which is under Application Management.

Then select the particular web application and 
then click on Manage Features and 
you should be able to see our feature.

Now to see the timer job, 
open SharePoint 2016 central administration, 
then click on Monitoring and then click on “Review job definitions” which is under Timer Jobs. 
You can see your custom timer job like below:
 */

/* 6) Debug
 debug -> attach -> OWSTIMER.EXE
If the breakpoint did not hit then you can restart the timer job service.
You can also run the timer job immediately by running the job now
 */

/* 7) Configuration options
SPYearlySchedule yearschedule = new SPYearlySchedule();
yearschedule.BeginMonth = 1;

SPMonthlySchedule monthschedule = new SPMonthlySchedule();
monthschedule.BeginDay = 1;

SPWeeklySchedule schedule = new SPWeeklySchedule();
schedule.BeginDayOfWeek = DayOfWeek.Monday;

SPDailySchedule daySchedule = new SPDailySchedule();
daySchedule.BeginHour = 9;

SPHourlySchedule hourSchedule = new SPHourlySchedule();
hourSchedule.BeginMinute = 10;
 */

/* 8) Errors
Admin SVC must be running in order to create deployment timer job error in SharePoint
restart "SharePoint 2010 Administration" service

Failed to load receiver assembly timerjobprocess version for feature System.IO.FileNotFoundException:
Could not load file or assembly or one o its dependencies. The system cannot find the file specifies
restart iis and sharepoint timer service service

Error occurred in deployment step add solution a timerjobprocess feature with ID 
FeatureID has already been installed in this farm. 
Use the force attribute to explicitly re-install the feature in SharePoint 2016 timer job
force deploy
 */