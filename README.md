## Lift King 🏋️‍♂️👑

A legacy desktop application designed to manage inventory...

> 💾 **80s Tech Disclaimer:** This app is fully optimized for 1988 IBM Workstations. Stored safely in an MS Access file—if we run out of space, we’ll just mail you another floppy disk. Please do not use while wearing fingerless mesh gloves; static electricity may wipe the database. (its a joke)

## 🚀 Project Overview

Lift King provides a seamless interface for managing a specialized retail store. It bridges a native Windows graphical user interface with a relational database back-end to handle standard retail operations like stock tracking, processing transactions, and generating sales summaries.

🛠️ Tech Stack

    Frontend & Logic: VB.NET (Windows Forms Application)

    Database: Microsoft Access (.accdb relational database via OLEDB connection)

    IDE: Visual Studio

📋 Core Features

    Inventory Management: Add, update, and track gym equipment stock levels (weights, machines, accessories) in real-time.

    Point of Sale (POS): Simulates processing customer purchases, calculating totals, and updating stock quantities automatically upon checkout.

    Database Connectivity: Leverages relational tables in MS Access to safely store customer records, item details, and transaction history.

## 💻 Getting Started

### 📋 Prerequisites & Database Drivers

To allow *Lift King* to communicate with the MS Access database layer without throwing an OLEDB provider error, your machine needs the 32-bit driver.

1. **Download the Driver:**
   * Download the official **[Microsoft Access Database Engine 2016 Redistributable](https://www.microsoft.com/en-us/download/details.aspx?id=54920)**.
   * Make sure to select the 32-bit version: `accessdatabaseengine.exe` (do *not* download the `_X64` version).

2. **⚠️ How to Bypass the Microsoft Installation Error:**
   If you already have 64-bit Microsoft Office installed, the installer will block you and throw an error. You can easily bypass this check by forcing a quiet installation via the Command Prompt (`cmd`):

   * Move the downloaded file directly to your `C:\` drive.
   * Open **Command Prompt as Administrator**.
   * Run the following command to force the installation:
   
```cmd
   C:\accessdatabaseengine.exe /quiet
   
💾 How to Run the App

    For Developers: Clone the repository and open the .sln (Solution) file directly in Visual Studio. Ensure your machine has the proper Microsoft Access Database Engine drivers installed to facilitate the OLEDB connection.

    For Users: To test the application directly without setting up an IDE, navigate to the Releases section on the right sidebar to download the standalone executable (.exe).


