gtk_sharp_dep = dependency('gtk-sharp-3.0')

thumbsget4gtk_sources = [
  'main.cs',
]

executable('thumbsget4gtk', thumbsget4gtk_sources,
  dependencies: gtk_sharp_dep,
       install: true,
   install_dir: join_paths(get_option('prefix'), 'libexec'),
)

cdata = configuration_data()
cdata.set('libexecdir', join_paths(get_option('prefix'), 'libexec'))
configure_file(
          input: 'thumbsget4gtk.in',
         output: 'thumbsget4gtk',
  configuration: cdata,
        install: true,
    install_dir: get_option('bindir'),
)
