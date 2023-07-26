# Running the tests
**Pre-requisites:**
1. [Visual Studio](https://visualstudio.microsoft.com/downloads/)
2. .NET Core

**Steps:**
1. Clone this project
2. Open the project in Visual Studio
3. Execute the tests from the Test Explorer Window

# Test Cases
* Verify that a User can Click on JS Alert then click OK in the Alert 
    1. Load the page
    2. Click on the JS Alert button
    3. Click OK on the Alert pop-up
    4. Assert that the result text is as expected
* Verify that a User can Click on JS Confirm then click OK in the Alert 
    1. Load the page
    2. Click on the JS Confirm button
    3. Click OK on the Alert pop-up
    4. Assert that the result text is as expected
* Verify that a User can Click on JS Confirm then click Cancel in the Alert
    1. Load the page
    2. Click on the JS Confirm button
    3. Click Cancel on the Alert pop-up
    4. Assert that the result text is as expected    
* Verify that a User can Click on JS Prompt then click Cancel in the Alert
    1. Load the page
    2. Click on the JS Prompt button
    3. Click Cancel on the Alert pop-up
    4. Assert that the result text is as expected    
* Verify that a User can Click on JS Prompt then Input Text in the Alert and Click Ok
    1. Load the page
    2. Click on the JS Prompt button
    3. Input text on the Alert text field
    4. Click Ok on the Alert pop-up
    5. Assert that the result text is as expected   
