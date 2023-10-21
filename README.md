# Blockter

This application was generated using JHipster 7.8.1 and JHipster .Net Core 3.9.1, you can find documentation and help at https://jhipsternet.readthedocs.io/en/latest/index.html and [https://www.jhipster.tech/documentation-archive/v7.8.1](https://www.jhipster.tech/documentation-archive/v7.8.1).

## Development

Before you can build this project, you must install and configure the following dependencies on your machine:

1. [Node.js][]: We use Node to run a development web server and build the project.
   Depending on your system, you can install Node either from source or as a pre-packaged bundle.

After installing Node, you should be able to run the following command to install development tools.
You will only need to run this command when dependencies change in [package.json](package.json).

In ./src/Blockter/ClientApp run

    npm install

We use npm scripts and [Webpack][] as our build system.

Run the following commands in two separate terminals to create a blissful development experience where your browser
auto-refreshes when files change on your hard drive.

    dotnet run --verbosity normal --project ./src/Blockter/Blockter.csproj
    npm --prefix ./src/Blockter/ClientApp start

npm is also used to manage CSS and JavaScript dependencies used in this application. You can upgrade dependencies by
specifying a newer version in [package.json](package.json). You can also run `npm update` and `npm install` to manage dependencies.
Add the `help` flag on any command to see how you can use it. For example, `npm help update`.

The `npm --prefix ./src/Blockter/ClientApp run` command will list all of the scripts available to run for this project.

### Managing dependencies

For example, to add [Leaflet][] library as a runtime dependency of your application, you would run following command:

    npm --prefix ./src/Blockter/ClientApp install --save --save-exact leaflet

To benefit from TypeScript type definitions from [DefinitelyTyped][] repository in development, you would run following command:

    npm --prefix ./src/Blockter/ClientApp install --save-dev --save-exact @types/leaflet

Then you would import the JS and CSS files specified in library's installation instructions so that [Webpack][] knows about them:
Edit [Blockter/ClientApp/app/vendor.ts](Blockter/ClientApp/app/vendor.ts) file:

```
import 'leaflet/dist/leaflet.js';
```

Edit [Blockter/ClientApp/content/css/vendor.css](Blockter/ClientApp/content/css/vendor.css) file:

```
@import '~leaflet/dist/leaflet.css';
```

Note: there are still few other things remaining to do for Leaflet that we won't detail here.

### Using angular-cli

You can also use [Angular CLI][] to generate some custom client code.

For example, the following command:

    ng generate component my-component

will generate few files:

    create Blockter/ClientApp/src/app/my-component/my-component.component.html
    create Blockter/ClientApp/src/app/my-component/my-component.component.ts
    update Blockter/ClientApp/src/app/app.module.ts

## Building for production

To build the artifacts and optimize the Blockter application for production, run:

    cd ./src/Blockter
    rm -rf ./src/Blockter/wwwroot
    dotnet publish --verbosity normal -c Release -o ./app/out ./Blockter.csproj

The `./src/Blockter/app/out` directory will contain your application dll and its depedencies.

This will concatenate and minify the client CSS and JavaScript files. It will also modify `index.html` so it references these new files.

## Code style / formatting

To format the dotnet code, run

    dotnet format

## Testing

To launch your application's tests, run:

    dotnet test --verbosity normal

### Client tests

In ClientApp folder run :

    npm test

### Generate entities

With cli

```bash
jhipster entity <entity-name>
```

or with jdl (https://start.jhipster.tech/jdl-studio/)

```bash
jhipster import-jdl my_file.jdl
```

### Code quality

By Script :

1. Run Sonar in container : `docker-compose -f ./docker/sonar.yml up -d`

2. Wait container was up Run `SonarAnalysis.ps1` and go to http://localhost:9001

Manually :

1. Run Sonar in container : `docker-compose -f ./docker/sonar.yml up -d`

2. Install sonar scanner for .net :

`dotnet tool install --global dotnet-sonarscanner`

3. Run `` dotnet sonarscanner begin /d:sonar.login=admin /d:sonar.password=admin /k:"Blockter" /d:sonar.host.url="http://localhost:9001" /s:"`pwd`/SonarQube.Analysis.xml" ``

4. Build your application : `dotnet build`

5. Publish sonar results : `dotnet sonarscanner end /d:sonar.login=admin /d:sonar.password=admin`

6. Go to http://localhost:9001

### Monitoring

1. Run container (uncomment chronograf and kapacitor if you would use it): `docker-compose -f ./docker/monitoring.yml up -d`

2. Go to http://localhost:3000 (or http://localhost:8888 if you use chronograf)

3. (Only for chronograf) Change influxdb connection string by `YourApp-influxdb`

4. (Only for chronograf) Change kapacitor connection string by `YourApp-kapacitor`

5. (Only for chronograf) You can now add dashboard (like docker), see your app log in Cronograf Log viewer and send alert with kapacitor

## Build a Docker image

You can also fully dockerize your application and all the services that it depends on. To achieve this, first build a docker image of your app by running:

```bash
docker build -f ./Dockerfile-Back -t blockter .
```

Then run:

```bash
docker run -p 8080:80 blockter
```

Or you can simply run :

```bash
docker-compose -f .\docker\app.yml build
```

And

```bash
docker-compose -f .\docker\app.yml up
```

[node.js]: https://nodejs.org/
[yarn]: https://yarnpkg.org/
[webpack]: https://webpack.github.io/
[angular cli]: https://cli.angular.io/
[browsersync]: http://www.browsersync.io/
[jest]: https://facebook.github.io/jest/
[jasmine]: http://jasmine.github.io/2.0/introduction.html
[protractor]: https://angular.github.io/protractor/
[leaflet]: http://leafletjs.com/
[definitelytyped]: http://definitelytyped.org/
