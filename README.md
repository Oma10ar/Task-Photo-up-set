PhotoUpSet 📸

A simple Windows Forms application built with C# and .NET Framework to demonstrate dynamic image switching using embedded resources.
💡 Project Purpose

The main goal of this project is to practice handling Embedded Resources. Instead of using absolute file paths, the images are compiled directly into the assembly, ensuring the application runs flawlessly on any machine without missing file errors.
🛠 Technical Stack

    Framework: .NET Framework 4.7.2.

    Language: C#.

    UI: Windows Forms (WinForms).

🚀 Features

    Resource-Based Images: Uses Properties.Resources to load images internally.

    Dynamic UI: Changes the PictureBox content based on button clicks.

    Clean Code: Separation between logic (frmPhoto.cs) and designer code (frmPhoto.Designer.cs).

📂 How it Works

The application switches the Image property of the pbPhoto control using the following logic:

    Up Button: Displays the upman resource.

    Set Button: Displays the setman resource.

    Sunrise Button: Displays the sunman resource.
