# VENative Blazor Service Generator

VENative Blazor Service Generator is a project designed to simplify applications created with Blazor Web App. By leveraging source code generators, this project automatically creates a SignalR hub for your services and generates a consumer for this hub on the WebAssembly client. This eliminates the need for manual client-side implementation, accelerating the development process for your Blazor applications while enhancing interactivity.

## Project Status
This project is in its early stages of development. As such, it is **not recommended** for use in production environments due to the high likelihood of breaking changes.

## Features
- **Automatic SignalR Hub Generation**: Automatically generates a SignalR hub for your services.
- **WebAssembly Client Integration**: Creates a consumer for the SignalR hub, eliminating manual client-side implementation.
- **Improved Development Speed**: Simplifies and accelerates the development of interactive Blazor applications.

## Considerations
1. **Authentication and Authorization**: Authentication and authorization need to be addressed, as SignalR hubs support method-level authorization.
2. **Security**: Potential vulnerabilities must be analyzed and mitigated.
3. **Testing**: More test cases need to be developed to ensure reliability and robustness.

## How to Use
- Clone the repository.
- Run the example Blazor project included in the repository.

## Limitations
- No NuGet package is currently available.

---

Feel free to contribute to the development of this project by submitting issues or pull requests. Your feedback and suggestions are welcome!
