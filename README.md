# TestSP2

# Computer Mouse Quality Assurance

## 1. Testing for a Computer Mouse

To ensure the highest quality of a computer mouse, various types of testing can be used. Here are some types of testing we could use on a computer mouse:

### Functional Testing:

- Check that all buttons work, including left-click, right-click, and scroll wheel.
- Ensure that the mouse pointer responds to movement.


### Durability Testing:

- stress testing the mpuse, such as repeatedly clicking the buttons.

### Compatibility Testing:

- Test the mouse on different operating systems Windows, macOS and Linux to ensure it works with different platforms.
- Check compatibility with different devices (laptops, desktops) and connectivity options such as USB and Bluetooth

### Drop Testing:

- Drop the mouse from various heights to simulate accidental drops and check if it can work and dont can take a fall without damage.

### Wireless Connectivity Testing:

- Ensure that wireless mice maintain a stable connection without any problems.
- Test battery life and charging functionality for wireless mice

### Firmware and Driver Testing:

- Test mouse firmware and driver updates to ensure they don't introduce issues or conflicts with the operating system

## 1.2. Story of Software System Defect

One notable software system defect with a catastrophic outcome is the Therac-25 radiation therapy machine incident in the 1980s. The Therac-25 was a medical linear accelerator used for radiation therapy. Due to a software bug, it administered massive overdoses of radiation to several patients, leading to severe injuries and deaths.

### What happened:

- The software bug allowed the machine to deliver radiation in high-powered "electron mode" without the intended safeguards.
- Patients received lethal doses of radiation, leading to radiation burns and fatalities.

### A test that could have prevented this catastrophe:

- Comprehensive system integration testing: This test would have checked the entire system, including the software, hardware, and safety interlocks, to ensure that the machine operated safely and as intended.
- Boundary testing: Testing the system's limits, such as maximum radiation dosage, to ensure that it could not exceed safe levels.
- Failure mode and effects analysis (FMEA): Identifying potential failure modes and their consequences could have helped in uncovering this critical defect.

The Therac-25 incident underscores the importance of rigorous testing, especially in safety-critical systems like medical devices, to prevent catastrophic failures and protect human lives.

## Two Katas  
Complete the following using BDD.  

### String Unity  
Use BDD to create a string utility with the following methods:  
* Reverse string (aBc -> cBa)
* Capitalize string (aBC -> ABC)
* Lowercase string (aBc -> abc)

Don't use any built-in string utility – create your own. Remember, the exercise here is to
use BDD, not to deliver a working utility without tests. If there are no tests in the
solution, it won’t be accepted.  

### Bowling Game Kata  
Complete the Bowling Game Kata using BDD. The slides can be found here:  
http://butunclebob.com/files/downloads/Bowling%20Game%20Kata.ppt  

## Investigation Of Tools  

# JUnit 5 (Jupiter) Overview

JUnit 5 (Jupiter) is a popular Java testing framework with various annotations and features for writing unit tests. Below are key annotations and their usefulness:

## Annotations

- **@Tag**: Tag test methods or classes with user-defined labels to categorize and organize tests. Useful for selective test execution based on tags, aiding in test suite optimization.

- **@Disabled**: Temporarily disable a test method or class without removing it from the codebase. Useful for skipping tests during development or maintenance and re-enabling them when needed.

- **@RepeatedTest**: Repeat a test method a specified number of times. Useful for running tests with different inputs to ensure stability and reliability.

- **@BeforeEach** and **@AfterEach**: Run methods before and after each test method. Useful for setting up and tearing down common test fixtures.

- **@BeforeAll** and **@AfterAll**: Run methods once before and after all test methods in a test class. Useful for one-time setup and teardown tasks for the entire test class.

- **@DisplayName**: Provide custom display names for test methods and classes, improving test report readability.

- **@Nested**: Create inner test classes within a test class, organizing tests hierarchically for better separation of concerns.

- **assumeFalse** and **assumeTrue**: Conditional assumptions within test methods. Skip tests on specific conditions or environments rather than marking them as failed.

# Mocking Frameworks Overview

Mocking frameworks are essential for testing. Here, we'll compare Mockito and EasyMock, two popular mocking frameworks for Java:

## Common Features

- **Mock Object Creation**: Both Mockito and EasyMock allow the creation of mock objects to simulate dependencies in tests.

- **Stubbing**: Both frameworks provide methods to define mock object behavior, like specifying return values or exceptions for specific method calls.

- **Verification**: Both frameworks offer mechanisms to verify that specific methods on mock objects are called with expected arguments and in the correct order.

## Differences

- **Syntax**: Mockito typically has a more user-friendly and expressive syntax, making test code more readable. EasyMock uses a different syntax, sometimes more verbose.

- **Strict vs. Lenient Mocking**: EasyMock is more strict by default, enforcing the order of method calls and treating unexpected calls as errors. Mockito is more lenient but allows for strict behavior when needed.

- **Partial Mocking**: Mockito allows partial mocking, meaning you can mock specific methods of a real object while allowing others to behave normally. EasyMock supports partial mocking but may require more effort.

- **Spying**: Mockito introduces "spying," allowing the creation of real objects with selectively mocked or stubbed methods, useful for testing classes with mixed behavior.

## Preference

The choice between Mockito and EasyMock often depends on personal preference, project needs, and team testing styles. Many developers prefer Mockito for its intuitive syntax and flexibility. However, if your project uses EasyMock or requires strict behavior, it might be the better choice. Ultimately, the decision hinges on familiarity, project requirements, and team practices.

