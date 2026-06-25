AI Chatbot & Productivity App

A multi-feature desktop application built with WPF (C#) that combines an AI chatbot interface, task reminders, activity logging, and a simple quiz game. The app is designed as a beginner-friendly but expandable system for learning desktop development.

✨ Features
💬 Chat System
Chat-style interface for user interaction
Message input and send functionality
ListView-based conversation display
📝 Task Reminders
Add and manage tasks
Mark tasks as completed (double-click)
Delete completed tasks
📜 Activity Log
Tracks user actions inside the app
Displays history of interactions
Helps monitor app usage flow
🎮 Quiz Game
Multiple-choice quiz system
Score tracking
Question display and answer selection
👤 Username System
User enters a username at startup
Basic validation for empty input
Personalized experience setup
🏠 Navigation System
Sidebar menu navigation:
Chats
Task Reminders
Activity Log
Game
Exit
🛠️ Tech Stack
Language: C#
Framework: WPF (.NET)
UI Markup: XAML
IDE: Visual Studio
📁 Project Structure
/MainWindow.xaml        → Main UI layout
/MainWindow.xaml.cs     → Logic & event handling
/Pages (conceptual)     → Chat, Tasks, Log, Game grids
/Assets                 → Images (logo, icons)
🚀 How to Run
Open the project in Visual Studio
Restore NuGet packages (if any)
Build the solution
Run using F5
🧠 How It Works
The app uses multiple Grid pages that are shown/hidden for navigation
Each feature (Chat, Tasks, Game, Log) is handled inside its own section
User interactions are captured using Button Click and MouseDoubleClick events
Data is displayed using ListView controls
🎯 Future Improvements
🤖 Real AI integration (OpenAI API or local model)
💾 Save data to file or database
🎨 Modern UI redesign (Fluent/Material Design)
🔔 Notifications for tasks
📊 Analytics dashboard for activity log
🎮 Improved quiz engine (timers, levels, categories)
📸 Screenshots (Optional)

Add screenshots of:

Home page
Chat UI
Quiz game
Task reminders
Activity log
👨‍💻 Author

Built by Tyrone (Student Developer)
Project focused on learning WPF UI design, navigation systems, and event-driven programming.
