FROM microsoft/wcf:4.6.2

# Next, this Dockerfile creates a directory for your application
WORKDIR ManageNumber.Service

# configure the new site in IIS.
RUN powershell -NoProfile -Command \
    Import-module IISAdministration; \
    New-IISSite -Name "ManageNumber.Service" -PhysicalPath C:\ManageNumber.Service -BindingInformation "*:8733:"

# This instruction tells the container to listen on port 8733. 
EXPOSE 8733

# The final instruction copies the site you published earlier into the container.
COPY ManageNumber.Service/ .