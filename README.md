# wcf-message-level-security-by-example
This article will describe how to implement WCF message level security. It will show you the required steps to create the WCF library, host it in IIS, secure with Message Level Security, client application and finally see encrypted messages using WCFTraceViewer.

## What is WCF Message Security
Message level security encrypts request and response messages using WS-Security specifications. It encloses security credentials and claims with every message. Each message either signed or encrypted. Message Security provides end-to-end channel security and is independent of the transport protocol. In short mutual authentication and message security is delivered at the message level.

## Applications

1. **[WCF Service with Message level security](https://github.com/geeksarray/wcf-message-level-security-by-example/tree/master/NorthwindMessageSecurity/NorthwindServices)** - WCF Services with IProducts Service Contract implemented.

1. **[Client App](https://github.com/geeksarray/wcf-message-level-security-by-example/tree/master/NorthwindMessageSecurity/NorthwindApp)** - Console application which acts as client application for Products WCF Service.


Following picture shows WCF Service secured messages.

![WCF Service Message level security](https://geeksarray.com/images/blog/NorthwindTrace.png)

For more detailed information visit - https://geeksarray.com/blog/wcf-message-level-security-by-example
