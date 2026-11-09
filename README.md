# LayoutDemoApp (.NET MAUI)

## 📌 Project Overview
This project is a cross-platform mobile application built using **.NET MAUI** (Multi-platform App UI). It was developed to demonstrate the practical use of Xamarin.Forms / .NET MAUI layout containers to build a responsive and visually appealing user interface.

The app features a "Dashboard" profile page that showcases how to combine different layout views to create a structured, modern UI that adapts to light and dark themes.

## 🛠️ Technologies Used
* **Framework:** .NET MAUI (C# & XAML)
* **Target Platforms:** Windows, Android, iOS, macOS (Mac Catalyst)
* **Tools:** Visual Studio 2022, Git, GitHub

## 📱 Layouts Demonstrated
The `MainPage.xaml` acts as a showcase for the following layout containers:

1. **Grid:** Used for the overall page structure, aligning the header text with the notification badge, and structuring the 3-column statistics row.
2. **StackLayout (Vertical & Horizontal):** Used to stack the text elements in the profile card and to group text under the stat numbers.
3. **AbsoluteLayout:** Used in the top-right header to overlay a red notification dot precisely on top of the bell icon.
4. **FlexLayout:** Used to display the list of tags (Design, Mobile, UI, etc.). The `Wrap="Wrap"` property ensures the tags automatically flow to the next line when the screen width changes (responsive design).
5. **ScrollView:** Wraps the entire content so the user can scroll down on smaller screens.
6. **RefreshView:** Enables a pull-to-refresh gesture to simulate loading new data.

## ✨ Key Features
* **Theme Support:** Full Light and Dark mode support using `AppThemeBinding` and dynamic resources.
* **Loading State:** An `ActivityIndicator` is shown for 2 seconds on startup before revealing the main content.
* **Interactive UI:** 
  * A "Follow/Unfollow" toggle button that updates the follower count.
  * Clickable tags that highlight when tapped.
  * A search bar that filters the visible tags in real-time.
* **Pull-to-Refresh:** Swiping down on the dashboard simulates fetching new data.

## 🚀 How to Run This Project
1. **Clone the repository:**
   ```bash
   git clone https://github.com/S-Shipra/LayoutDemoApp.git
