# Student360

Student360 is an application that is intended to show all information relevant
to the student's grades, schedules, attendance, transcript, and Texas Education
Program with special emphasis on attendance and time remediation among other
important data items -as a one stop shop with a quick overview.  It also
includes an attendance map, a powerful flexible report viewer so you can write
and include your custom SSRS reports built in-house This is a Web based
application written in .NET Core (C#) and SQL server and angular 8+ (UI) and
supports google authentication/AD. It runs on-prem but it can also be hosted on
Azure/AWS.

For more information on this project, please see [Student360 in the Ed-Fi
Exchange](https://techdocs.ed-fi.org/display/EXCHANGE/Student360).

## Installation Requirements

* .NET Core 3.1
* IIS on Windows Server
* SQL Server 2016+
* Ed-Fi ODS/API for Suite 3, version 3.1 or 3.2
* An SMTP account, for example from SendGrid or another mail provider

## Using the Solution

1. In the source code, [Restore BoldReports](docs/Restoring-BoldReports.md).
1. Acquire a trial or paid license for [BoldReports](https://www.boldreports.com/)
1. Setup a [Google Maps](https://cloud.google.com/maps-platform/pricing) account.
1. Adjust the [appsettings.json](docs/Configuration.md) file and the report connection strings.
1. Compile the solution and deploy into IIS.
1. Install the [SQL views](SMCISD.Student360.SQLScriptsExtra/) into your ODS database.

## Legal Information

Copyright (c) 2021 Ed-Fi Alliance, LLC and contributors.

Licensed under the [Apache License, Version 2.0](LICENSE) (the "License").

Unless required by applicable law or agreed to in writing, software distributed
under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
CONDITIONS OF ANY KIND, either express or implied. See the License for the
specific language governing permissions and limitations under the License.

See [NOTICES](NOTICES.md) for additional copyright and license notifications.
