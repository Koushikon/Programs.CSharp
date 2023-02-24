# Sending Mail

Sending Mail with SendGrid Inside an Console Application

## Setp Up Keys

Set Enviroment Variables Inside Windows. For our case we set two Enviroment Variables `MailFrom` and `SENDGRID_API_KEY`.

- Inside `MailFrom` we set our Mail Id which is used for Mail From and Mail To.
- Inside `SENDGRID_API_KEY` we set our Sendgrid API Key which is used for Authentication of Sending Mail.


### Create an New Enviroment Variables

- Add Variable Name of that Secret.
- Add Variable Value of that Secret.
- Save the Enviroment Variable.
- Restart the PC and Start using it.

```
Environment.GetEnvironmentVariable(<secret_variable_name>);
```


