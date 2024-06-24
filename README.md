# SLIDELY-FORMS-APP

## Overview

This is the frontend application for the Slidely Form App. It allows users to create and view form submissions with a built-in stopwatch timer.

## Features

- **Create Submissions:** Users can fill out a form to create new submissions, including their name, email, phone number, GitHub link, and the stopwatch time.
- **View Submissions:** Users can view all previously created submissions.
- **Stopwatch:** A built-in stopwatch timer to track time for each submission.
- **Keyboard Shortcuts:** Quick access to create and view submissions using keyboard shortcuts.

## Keyboard Shortcuts

- **Ctrl + V:** Open the View Submissions form
- **Ctrl + C:** Open the Create Submissions form
- **Ctrl + T:** Start/Pause the stopwatch
- **Ctrl + S:** Submit the form
- **Ctrl + R:** Reset the stopwatch
- **Ctrl + Q:** Exit the application

## Setup

1. **Clone the repository:**
 ```
   git clone https://github.com/vedanshi0512/slidely-form-app-backend.git
   cd slidely-form-app-backend
```

2. **Open the project:**

Open the project in Visual Studio or your preferred VB.NET development environment.

3. **Run the application:**

Build and run the application in your development environment.

![home page.jpeg](https://github.com/vedanshi0512/slidely-form-app-frontend/blob/master/home%20page.jpeg)

# Functionality
**Create Submission Form**

![Create Submission](https://github.com/vedanshi0512/slidely-form-app-frontend/blob/master/create%20submission.jpeg)


*Fields:*

-Name

-Email

-Phone

-GitHub Link

-Stopwatch Time

*Buttons:*

-Start/Pause Stopwatch

-Reset Stopwatch

*Submit Form*

-View Submissions Form

![View Submission](https://github.com/vedanshi0512/slidely-form-app-frontend/blob/master/view%20submission%20page.jpeg)

*Displays:*
-List of all submissions

-Each submission includes name, email, phone, GitHub link, and stopwatch time

*Buttons:*
Previous,
Next,
Delete,
Edit.

![Delete Submission](https://github.com/vedanshi0512/slidely-form-app-frontend/blob/master/delete%20submission.jpeg)
![Edit Submission](https://github.com/vedanshi0512/slidely-form-app-frontend/blob/master/edit%20submission.jpeg)

# Flowchart

Below is the flowchart illustrating the flow of the application:

```mermaid
[Start] --> [Main Form]
    |-- Ctrl+C --> [Create Submissions Form]
    |-- Ctrl+V --> [View Submissions Form]

[Create Submissions Form]
    |-- Ctrl+T --> [Start/Pause Stopwatch]
    |-- Ctrl+S --> [Submit Form]
    |-- Ctrl+R --> [Reset Stopwatch]
    |-- Submit --> [Save Data to Backend] --> [Main Form]

[View Submissions Form]
    |-- Previous/Next --> [Navigate Submissions]
    |-- Delete --> [Delete Submission]
    |-- Edit --> [Edit Submission]
    |-- Return --> [Main Form]
```


## License

[Vedanshi](https://github.com/vedanshi0512)
