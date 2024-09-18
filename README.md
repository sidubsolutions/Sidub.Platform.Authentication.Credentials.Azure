# Sidub Platform - Authentication - Azure Credentials

This repository contains the Azure credentials implementation for the
authentication module within the Sidub Platform. It provides credentials used
when identifying against Azure resources.

## Main Components
Only credentials are provided within this repository for use within the Sidub
Platform authentication module.

### Credentials
Available credentials within this package include:
- `ServiceTokenCredential` - used when the service identity is used to
  authenticate against Azure resources.
- `UserTokenCredential` - used when a user identity is used to authenticate
  against Azure resources.

## License
This project is dual licensed under the AGPL v3 or a proprietary license. For
details, see [https://sidub.ca/licensing](https://sidub.ca/licensing) or the
LICENSE.txt file.
