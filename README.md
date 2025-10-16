# Pawjections
An interactive game system designed to encourage cats to engage in active play.

## Contributing

The Unity VCS repository is the canonical source of truth. GitHub is synchronized via GitSync for visibility and external contributions. External contributors may use GitHub exclusively — maintainers will sync merged changes back to Unity VCS.

You may contribute through either Unity VCS or Git, depending on your workflow. Unity VCS offers tighter integration with the Unity Editor and is recommended for in-editor changes. Git may be simpler if you're accustomed to it or working with files outside the Unity Editor.

### Using Unity VCS

> [!NOTE]
> Follow these instructions if you do not have write access to the Unity VCS repository (ex. if you are an outside contributor), but still want to work with Unity VCS to track your changes. Otherwise, if you have write access, you may contribute directly to the repository.

1. [Fork the repository](https://github.com/thatrobotdev/Pawjections/fork)
2. Pull your fork into [Unity VCS](https://docs.unity.com/ugs/en-us/manual/devops/manual/migrating-from-git#the-first-pull)
3. Make changes to your fork (it is suggested to create a Task branch that works on one Issue for easy code review and merging. [You can see an example workflow here](https://docs.unity.com/ugs/en-us/manual/devops/manual/unity-version-control#example-workflow).)
4. *(Optional)* Configure your [`gitsync.conf`](https://docs.unity.com/ugs/en-us/manual/devops/manual/migrating-from-git#the-gitsyncconf-file) file to link your Unity VCS changesets to your GitHub identity. This ensures your contributions appear correctly attributed when mirrored to GitHub.
    1. Retrieve your Unity VCS username
        ```sh
        $ cm whoami
        uvcs_user
        ```
    2. Add the following to your `gitsync.conf` file.
        ```sh
        [email-mapping]
        uvcs_user = user@email.com
        ```
        where `user@email` is an [email associated with your GitHub account](https://docs.github.com/en/account-and-profile/how-tos/setting-up-and-managing-your-personal-account-on-github/managing-email-preferences/adding-an-email-address-to-your-github-account).

        **Note**: Your Unity VCS username could be formatted as an email, so `user@domain.com = user@domain.com` is a valid mapping.

5. [Push your branch to GitHub](https://docs.unity.com/ugs/en-us/manual/devops/manual/migrating-from-git#pushing-to-git).
6. Create a Pull request targeting upstream with your changes.

### Using Git

1. [Fork the repository](https://github.com/thatrobotdev/Pawjections/fork)
2. Make changes to your fork.
3. Push your branch to GitHub.
4. Create a Pull request targeting upstream with your changes.
