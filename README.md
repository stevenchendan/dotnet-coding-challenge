# .NET Code Challenge

## 1. Background:

This is a coding challenge which output horses into console.

## 2. Running Application:

Please make sure you have Visual studio installed in your computer.

If you do not have Visual studio please make sure you install .net core manully.

After download this application to your computer, open the dotnet-code-challenge.sln with visual studio.

Then press Ctrl + F5 or just click the Run button at the top of Visual studio.


## 3. Recommended improvements:

Due to lack of time there are some more work to do:

- Use Dependency injection to write some unit tests
- Better logging system(handle exception)
- More defensive code
- Handle currency given different country or culture
- some methods are too big and not test friendly, need to wrap up into small pieces
- If this is real application I would recommend to host this application on AWS and use api gateway + lambda(.net core) + DynamoDb +  Cloudwatch + SNS topic... to build a serverless application.
- Add docker