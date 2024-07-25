# QRHostPopper

QRHostPopper is a service-like application that runs in the background and shows a QR code containing the hostname when specific keyboard shortcuts are pressed.

## Features

- Runs in the background
- Displays a QR code with the hostname on a keypress
- Uses a global hotkey (CTRL + ALT + WINDOWS + D) to trigger the QR code popup

## Installation

1. Clone the repository to your local machine:
    ```sh
    git clone https://github.com/iamahsanmehmood/QRHostPopper.git
    ```
2. Open the solution file in Visual Studio.
3. Restore the NuGet packages.
4. Build the solution.

## Usage

1. Run the application.
2. Use the shortcut `CTRL + ALT + WINDOWS + D` to display the QR code with the hostname.

## Code Overview

### MainForm.cs

This file contains the main logic of the application:
- Initialization and configuration of the form.
- Registration and handling of the global hotkey.
- Generation and display of the QR code.


### ShortcutKeysMessageFilter.cs

This file implements a message filter to handle the specified shortcut keys and trigger the QR code popup.

## Dependencies

- [QRCoder](https://github.com/codebude/QRCoder) - A library for generating QR codes.

## License

This project is licensed under the MIT License. See the [LICENSE]((https://github.com/iamahsanmehmood/QRHostPopper/blob/main/LICENSE.md)) file for details.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-branch`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-branch`).
5. Create a new Pull Request.

## Contact

If you have any questions or issues, please open an issue in the repository.

---

