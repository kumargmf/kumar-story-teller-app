# StoryBook Teller

An AI-powered storytelling application that creates engaging stories from your images using advanced AI technology powered by Amazon Bedrock and Anthropic's Claude.

## 🌟 Features

- **Image-to-Story Generation**: Upload up to three images and get a unique, engaging story
- **AI-Powered**: Utilizes Amazon Bedrock with Anthropic's Claude for advanced natural language generation
- **Responsive Design**: Modern, mobile-friendly interface built with ASP.NET Core and Bootstrap
- **Secure Processing**: Images are processed securely and not permanently stored

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- A modern web browser
- (Future) AWS Account with Bedrock access for full functionality

### Installation

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd StoryBookTeller
   ```

2. **Restore dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the project**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open your browser**
   Navigate to `https://localhost:7001` or `http://localhost:5000`

### Development Setup

For development with hot reload:
```bash
dotnet watch run
```

## 🏗️ Project Structure

```
StoryBookTeller/
├── Controllers/           # MVC Controllers
│   └── HomeController.cs
├── Models/               # Data models and ViewModels
│   ├── HomeViewModel.cs
│   └── ErrorViewModel.cs
├── Views/                # Razor views
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _ViewStart.cshtml
│       ├── _ViewImports.cshtml
│       └── Error.cshtml
├── wwwroot/              # Static files
│   ├── css/
│   ├── js/
│   └── lib/
├── Properties/
│   └── launchSettings.json
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
└── StoryBookTeller.csproj
```

## 🎨 Technology Stack

- **Backend**: ASP.NET Core 9.0 (MVC)
- **Frontend**: HTML5, CSS3, JavaScript, Bootstrap 5
- **AI Integration**: Amazon Bedrock + Anthropic's Claude (planned)
- **Development**: Visual Studio / VS Code compatible

## 🔧 Configuration

### Application Settings

The application uses `appsettings.json` for configuration:

```json
{
  "ApplicationSettings": {
    "ApplicationName": "StoryBook Teller",
    "Version": "1.0.0",
    "Description": "An AI-powered storytelling application..."
  }
}
```

### Environment-Specific Settings

- `appsettings.Development.json` - Development environment settings
- `appsettings.Production.json` - Production settings (create as needed)

## 🚧 Current Status

**Phase 1: Foundation** ✅ **COMPLETE**
- [x] Basic ASP.NET Core MVC structure
- [x] Responsive landing page
- [x] Development environment setup
- [x] Project documentation

**Phase 2: Image Upload** 🔄 **PLANNED**
- [ ] File upload functionality
- [ ] Image validation and processing
- [ ] Temporary storage management

**Phase 3: AI Integration** 📋 **PLANNED**
- [ ] Amazon Bedrock integration
- [ ] Anthropic Claude API implementation
- [ ] Story generation pipeline
- [ ] Error handling and retry logic

**Phase 4: Enhancement** 📋 **PLANNED**
- [ ] User authentication
- [ ] Story history and management
- [ ] Advanced customization options
- [ ] Performance optimization

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

### Development Guidelines

- Follow C# coding conventions
- Use meaningful commit messages
- Add appropriate comments for complex logic
- Test your changes thoroughly
- Update documentation as needed

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🔮 Future Enhancements

- **Multi-language Support**: Generate stories in different languages
- **Story Templates**: Pre-defined story styles and genres
- **Social Sharing**: Share generated stories on social media
- **API Access**: RESTful API for third-party integrations
- **Mobile App**: Native mobile applications
- **Advanced AI Options**: Multiple AI model choices and fine-tuning

## 📞 Support

If you encounter any issues or have questions:

1. Check the [Issues](../../issues) page for existing problems
2. Create a new issue with detailed information
3. Contact the development team

## 🙏 Acknowledgments

- [ASP.NET Core Team](https://github.com/dotnet/aspnetcore) for the excellent framework
- [Bootstrap](https://getbootstrap.com/) for the responsive UI components
- [Anthropic](https://www.anthropic.com/) for Claude AI technology
- [Amazon Web Services](https://aws.amazon.com/bedrock/) for Bedrock platform

---

**Built with ❤️ using .NET 9 and ASP.NET Core**