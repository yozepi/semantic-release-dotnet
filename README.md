# semantic-release-dotnet
Musings and experiments with semantic release and dotnet core.

I'm experimenting with integrating github actions, semantic-release, and packaging a .Net core dll.

I've learned the following so far:
- When pulling into a branch...
  - Perform a merge if you want the source branch to affect the versioning of the destination.
  - Perform a squash commit if you want to control how the versioning is done. Be sure to set your semantic message as desired (fix:, feat:, breaking change:, etc.)
  - Rebasing causes some weirdness because, when pulling from other semantic branches, the last check-in is usually the automated tag - which is marked with **[skip ci]**. This will keep your workflow from running.
  - When using *BREAKING CHANGE:* be sure you have at least one release that's pertinent to that build type first.
    Example: *BREAKING CHANGE:* will not work on the beta channel if there isn't a \*.\*.\*-beta.\* release first.
- Although unit tests can be run within @semantic-release, It's better to run them in github action prior to running @semantic-release. This is because @semantic-release will analyze all the changes before running the tests. Which is a waste of time if the tests are going to fail anyway.
- You will want to pack your package from within @semantic-release instead of within your github action. This is because, by the time the action has access to the new release version the release has already been tagged and the changelog overwritten. If your back (and build) should fail now, you will have to manually unwind the tagging and commits.


[Change Log](CHANGELOG.md)