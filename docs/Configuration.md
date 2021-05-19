# Configuration

## Adjusting the AppSettings File

| :exclamation: Take care that you do not accidentally commit these changes into a **public source code repository** on GitHub, BitBucket, etc. |
| -- |

### Required Settings

1. Update the `ConnectionStrings.DefaultConnection` to point to your ODS database.
1. Insert your Bold Reports license key into `BoldReports.LicenseToken`.
1. Create a secret key for signing the authentication tokens. This can be any
   string of at least 16 characters. Set this in `Jwt.Key`.
1. Setup the mail server with proper information in the `Message.Email` block.

### Optional Settings

All other settings are optional. Please review and experiment with different
settings as desired.

## Report Connection Strings

The database connection strings are currently hard-coded in two `.rdl` reports,
under `SMCISD.Student360.Web/wwwroot/Resources`. These can be edited manually. A
better long term solution would be to modify the `ReportViewerController` class
(C#) to inject the connection string at runtime, following [these
instructions](https://help.boldreports.com/report-viewer-sdk/javascript-reporting/report-viewer/how-to/change-datasource-dynamic-at-server-side/).

## Google API

Insert your Google Maps API key in `SMCISD.Student360.Web/ClientApp/src/index.html`.
