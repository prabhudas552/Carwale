module.exports = function (grunt) {
    pkg: grunt.file.readJSON('package.json'),
    grunt.initConfig({
        home: {
            uglify: {
                dist: {
                    files: {
                        'scripts/js/main.min.js': ['scripts/js/jquery-3.1.0.js', 'scripts/js/implementCall.js', 'scripts/js/makeCall.js'],
                    }
                }
            },
            cssmin: {
                target: {
                    files: {
                        'Styles/css/main.min.css': ['Styles/css/header.css', 'Styles/css/para.css']
                    }
                }
            },
            concat: {
                target: {
                    src: ['scripts/js/jquery-3.1.0.js', 'scripts/js/implementCall.js', 'scripts/js/makeCall.js'],
                    dest: 'scripts/js/main.js'
                }
            }
        },
        watch: {
            css: {
                files: ['Styles/css/*.css'],
                tasks:['home:cssmin']
            },
            js: {
                files: ['scripts/js/*.js'],
                tasks: ['home:uglify']
            }
        }

    });
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-cssmin');
    grunt.loadNpmTasks('grunt-newer');
    grunt.loadNpmTasks('grunt-changed');
    grunt.loadNpmTasks('grunt-contrib-concat');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.registerTask('Watch', ['watch']);
}