# Digitizing Solution

This solution digitizes Arabic and English papers, categorizes them, and stores the file paths in a SQL Server database.

## Prerequisites

* .NET Framework 4.7.2
* SQL Server
* Tesseract OCR

## Setup

1.  Clone the repository.
2.  Open the solution in Visual Studio.
3.  Download the Tesseract language data for Arabic and English from the [official Tesseract repository](https://github.com/tesseract-ocr/tessdata).
4.  Place the `ara.traineddata` and `eng.traineddata` files in the `DigitizingSolution/DigitizingSolution/bin/Debug/net472/tessdata` directory.
5.  Update the connection string in the `app.config` file to point to your SQL Server instance.
6.  Run the application.
