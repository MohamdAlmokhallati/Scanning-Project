# Scanning Project

## Overview

The Scanning Project is a C# Windows Forms application that enables users to scan documents, manage scanned images, and save them as PDFs. It supports connecting to scanners, handling multiple scanned images, and providing a user-friendly interface for saving the results.

## Features

- **Device Management**: Automatically detects available scanner devices.
- **Scanning Capability**: Allows scanning images with customizable DPI, color modes, and paper sizes.
- **Image Management**: Supports multiple image management, including navigation between scanned images.
- **PDF Export**: Saves scanned images as a single PDF file.
- **Custom Save Paths**: Allows users to specify and change the save directory for scanned files.

## Requirements

- **Platform**: Windows OS
- **Dependencies**:
  - `iText7` (for PDF generation)
  - `WIA` (Windows Image Acquisition API for scanner communication)
