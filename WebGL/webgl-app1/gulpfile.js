var gulp = require('gulp');
var bs = require('browser-sync').create(); // create a browser sync instance.
var reload = bs.reload;

gulp.task('browser-sync', function() {
    bs.init({
        server: {
            baseDir: "./"
        }
    });
    gulp.watch("*.html").on("change", reload);
    gulp.watch("*.js").on("change", reload);
});
