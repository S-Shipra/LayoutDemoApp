namespace LayoutsDemoApp.Pages;

public partial class MainPage : ContentPage
{
    private int _followers = 1280;
    private int _posts = 48;
    private bool _isFollowing = false;
    private bool _loaded = false;

    public MainPage()
    {
        InitializeComponent();
    }

    // ---- Loading state (ActivityIndicator) ----
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        if (_loaded) return;
        _loaded = true;

        await Task.Delay(2000);              // simulate loading
        Spinner.IsRunning = false;
        LoadingPanel.IsVisible = false;
        ContentStack.IsVisible = true;
    }

    // ---- Pull to refresh ----
    private async void OnRefreshing(object? sender, EventArgs e)
    {
        await Task.Delay(1500);              // simulate fetching new data
        _posts++;
        PostsLabel.Text = _posts.ToString();
        Refresher.IsRefreshing = false;
    }

    // ---- Follow / Unfollow toggle ----
    private void OnFollowClicked(object? sender, EventArgs e)
    {
        _isFollowing = !_isFollowing;
        _followers += _isFollowing ? 1 : -1;

        FollowButton.Text = _isFollowing ? "Unfollow" : "Follow";
        FollowersLabel.Text = _followers.ToString("N0");
    }

    // ---- Clickable tags: tap to highlight / un-highlight ----
    private void OnTagTapped(object? sender, TappedEventArgs e)
    {
        if (sender is not Border tag) return;

        if (tag.ClassId == "selected")
        {
            tag.ClassId = "";
            tag.ClearValue(BackgroundColorProperty);   // back to the themed style colour
            ResetLabelTheme(tag);
        }
        else
        {
            tag.ClassId = "selected";
            tag.BackgroundColor = (Color)Application.Current!.Resources["Accent"];
            if (tag.Content is Label l) l.TextColor = Colors.White;
        }
    }

    // Restores the label to its themed colour after deselecting
    private static void ResetLabelTheme(Border tag)
    {
        if (tag.Content is Label l)
            l.SetAppTheme(Label.TextColorProperty,
                (Color)Application.Current!.Resources["TextLight"],
                (Color)Application.Current!.Resources["TextDark"]);
    }

    // ---- Search bar: filter tags by typed text ----
    private void OnSearchChanged(object? sender, TextChangedEventArgs e)
    {
        string query = (e.NewTextValue ?? "").Trim();

        foreach (var child in TagLayout.Children)
        {
            if (child is Border tag && tag.Content is Label label)
            {
                tag.IsVisible = string.IsNullOrEmpty(query) ||
                                label.Text.Contains(query, StringComparison.OrdinalIgnoreCase);
            }
        }
    }

    // ---- Button click action ----
    private async void OnViewProfileClicked(object? sender, EventArgs e)
    {
        await DisplayAlert("Profile", "Opening full profile for Aarav Sharma...", "OK");
    }
}