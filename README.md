# semantic-release-dotnet
Musings and experiments with semantic release and dotnet core.

I'm experimenting with integrating github actions, semantic-release, and packaging a .Net core dll.

I've learned the following so far:
- When pulling into a branch...
  - Perform a merge if you want the source branch to affect the versioning of the destination.
  - Perform a squash commit if you want to control how the versioning is done. Be sure to set your semantic message as desired (fix:, feat:, breaking change:, etc.)
  - Rebasing causes some weirdness because, when pulling from other semantic branches, the last check-in is usually the automated tag - which is marked with **[skip ci]**. This will keep your workflow from running.


[Change Log](CHANGELOG.md)