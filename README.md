# test-deploy-asp.net

To start working on a new ```feature```.

1. Checkout to the ```develop``` branch and pull the latest changes:
```
git checkout develop
git pull
```

2. Create a new branch ```feature/my-new-feature```:
> Replace [my-new-feature] with a name that describes your new feature
```
git branch feature/my-new-feature
```

3. Checkout to the ```feature/my-new-feature```:
```
git checkout feature/my-new-feature
```

4. Make as many commits as you cant to your feature branch, once you are confident that it's tested and ready to be merged into ```develop``` branch you have first to push all changes to ```feature/my-new-feature```:
```
git push -u origin feature/my-new-feature
```

5. Merge it back into the ```develop``` branch:
```
git checkout develop
git merge --no-ff feature/my-new-feature
```

6. Push the updated ```develop``` branch to the remote repository:
```
git push origin develop
```

7. Create a new ```release``` branch from ```develop``` and checkout to it:
```
git checkout -b release/V1.0.0
```

8. Add a Git tag to the ```release``` branch (PS: youcan check the available tags using ``` git tag ```:
```
git tag V1.0.0
```

9. Merge the ```release``` branch into ```main```:
```
git checkout main
git merge --no-ff release/1.0.0
```

10. Push the updated ```main``` branch to the remote repository:
```
git push origin main
```
