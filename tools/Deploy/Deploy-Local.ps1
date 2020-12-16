# Website root folder (website is deployed here)
$website_root = "C:\inetpub\Umbraco Masterclass"

# Temporarily change to the correct folder containing script
$scriptPath = (Get-Variable MyInvocation -Scope Script).Value.MyCommand.Path
$currentFolder = Split-Path $scriptPath
Push-Location $currentFolder

# Set src folder based on location of script location in /tools/deploy
$src = ".\..\..\src\MyUCommerceApp.Website"

# Exclude files and folders from deploy, usually these are
# source code files, proj files from Visual Studio, and other
# files not required at runtime
$options = @("/E", "/S", "/xf", "*.cs", "/xf", "*.??proj", "/xf", "*.user", "/xf", "*.old", "/xf", "*.vspscc", "/xf", "xsltExtensions.config", "/xf", "uCommerce.key", "/xf", "*.tmp", "/xd", "_Resharper*", "/xd", ".svn", "/xd", "_svn", "/xf", "UCommerce.dll", "/xf", "UCommerce.Presentation.dll", "/xf", "UCommerce.Web.Api.dll", "UCommerce.Infrastructure.dll", "/xf", "UCommerce.Transactions.Payments.dll", "/xf", "UCommerce.Pipelines.dll", "/xf", "ServiceStack.*")

# Copy all site specific files into the website
& robocopy "$src\Controls" "$website_root\Controls" $options
& robocopy "$src\Bootstrap" "$website_root\Bootstrap" $options
& robocopy "$src\Css" "$website_root\Css" $options
& robocopy "$src\img" "$website_root\Img" $options
& robocopy "$src\Umbraco" "$website_root\Umbraco" $options
& robocopy "$src\Layouts" "$website_root\Layouts" $options
& robocopy "$src\Scripts" "$website_root\Scripts" $options
& robocopy "$src\bin" "$website_root\bin" MyUCommerceApp*.dll $options
& robocopy "$src\App_Code" "$website_root\App_Code" *.* $options
& robocopy "$src\Views" "$website_root\Views" *.* $options

# Now back to original directory
Pop-Location