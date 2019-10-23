project('thumbsget4gtk', 'cs',
          version: '0.1.0',
    meson_version: '>= 0.50.0',
  default_options: [ 'warning_level=2',
                   ],
)

i18n = import('i18n')


subdir('thumbsget4gtk/data')
subdir('thumbsget4gtk/src')
subdir('thumbsget4gtk/po')

meson.add_install_script('thumbsget4gtk/build-aux/meson/postinstall.py')
