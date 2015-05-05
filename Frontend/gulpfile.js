/// <binding AfterBuild='dev' />
var gulp = require("gulp");
var gutil = require("gulp-util");
var webpack = require("webpack");
var WebpackDevServer = require("webpack-dev-server");
var WebpackConfig = require('./webpack.config.js');

gulp.task("dev", function (callback) {
    // run webpack
    webpack(WebpackConfig, function (err, stats) {
        if (err) throw new gutil.PluginError("webpack", err);
        gutil.log("[webpack]", stats.toString({
            path: './dist2'
        }));
        callback();
    });
});

gulp.task("prod", function (callback) {
    // run webpack
    webpack(WebpackConfig, function (err, stats) {
        if (err) throw new gutil.PluginError("webpack", err);
        gutil.log("[webpack]", stats.toString({
    }));
        callback();
    });
});