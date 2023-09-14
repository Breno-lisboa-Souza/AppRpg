namespace AppRpgEtec;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		String login = Preferences.Get("UsuarioUsername", string.Empty);
		lblLogin.Text = $"Login: {login}";
	}
}
