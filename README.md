# Rename File Application

## English

### Overview
The **Rename File Application** is a Windows Forms application built with .NET 8 and C# 12. It provides a simple and user-friendly interface to rename files on your system. This application was specifically designed to handle files with long names that cannot be copied or renamed using traditional methods like PowerShell or Command Prompt. The application ensures error handling, file validation, and supports overwrite prompts for existing files.

### Features
- Select a file to rename using a file dialog.
- Save the renamed file to a new location.
- Handle files with long names that are otherwise difficult to manage.
- Validate file paths and handle errors gracefully.
- Overwrite prompt for existing destination files.

### Requirements
- **.NET 8 Runtime**: Ensure you have the .NET 8 runtime installed on your system.
- **Windows OS**: This application is designed for Windows platforms.

### How to Use
1. Open the application.
2. Click the **Open** button to select the source file.
3. Click the **Save** button to specify the destination file name and location.
4. Click the **Run** button to rename the file.
5. If the operation is successful, a success message will be displayed.

### Project Structure
- **`Program.cs`**: Entry point of the application.
- **`Form1.cs`**: Contains the main logic for file renaming and UI interactions.
- **`rename file.csproj`**: Project configuration targeting .NET 8 with Windows Forms enabled.

### Build and Run
1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Build the project to restore dependencies.
4. Run the application.

---

## فارسی

### معرفی
**برنامه تغییر نام فایل** یک برنامه ویندوزی است که با استفاده از .NET 8 و C# 12 ساخته شده است. این برنامه یک رابط کاربری ساده و کاربرپسند برای تغییر نام فایل‌ها در سیستم شما ارائه می‌دهد. این برنامه به طور خاص برای مدیریت فایل‌هایی طراحی شده است که به دلیل طولانی بودن نامشان نمی‌توان آن‌ها را با روش‌های معمول مانند PowerShell یا Command Prompt کپی یا تغییر نام داد. این برنامه از مدیریت خطا، اعتبارسنجی فایل و پشتیبانی از اعلان بازنویسی برای فایل‌های موجود پشتیبانی می‌کند.

### ویژگی‌ها
- انتخاب فایل برای تغییر نام با استفاده از دیالوگ فایل.
- ذخیره فایل تغییر نام داده شده در مکان جدید.
- مدیریت فایل‌هایی با نام‌های طولانی که به‌طور معمول قابل تغییر نیستند.
- اعتبارسنجی مسیر فایل و مدیریت خطاها.
- اعلان بازنویسی برای فایل‌های مقصد موجود.

### پیش‌نیازها
- **اجرای .NET 8**: اطمینان حاصل کنید که .NET 8 روی سیستم شما نصب شده است.
- **سیستم‌عامل ویندوز**: این برنامه برای پلتفرم‌های ویندوز طراحی شده است.

### نحوه استفاده
1. برنامه را باز کنید.
2. روی دکمه **Open** کلیک کنید تا فایل مبدا را انتخاب کنید.
3. روی دکمه **Save** کلیک کنید تا نام و مکان فایل مقصد را مشخص کنید.
4. روی دکمه **Run** کلیک کنید تا فایل تغییر نام داده شود.
5. در صورت موفقیت، یک پیام موفقیت نمایش داده می‌شود.

### ساختار پروژه
- **`Program.cs`**: نقطه ورود برنامه.
- **`Form1.cs`**: شامل منطق اصلی برای تغییر نام فایل و تعاملات رابط کاربری.
- **`rename file.csproj`**: پیکربندی پروژه با هدف .NET 8 و فعال‌سازی Windows Forms.

### ساخت و اجرا
1. مخزن را کلون کنید.
2. پروژه را در Visual Studio 2022 باز کنید.
3. پروژه را بیلد کنید تا وابستگی‌ها بازیابی شوند.
4. برنامه را اجرا کنید.
