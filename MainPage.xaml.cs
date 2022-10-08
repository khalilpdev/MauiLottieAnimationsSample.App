using Microsoft.Maui.Controls;

namespace MauiLottieAnimationsSample;

public partial class MainPage : ContentPage
{
    int count = 0;
    bool isDark;


    public MainPage()
    {
        InitializeComponent();
        isDark = Application.Current.UserAppTheme == AppTheme.Dark;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    private void OnThemeClicked(object sender, EventArgs e)
    {
        isDark = !isDark;

        if (isDark)
            Application.Current.UserAppTheme = AppTheme.Dark;
        else
            Application.Current.UserAppTheme = AppTheme.Light;

    }

}

