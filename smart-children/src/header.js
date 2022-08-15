import React from 'react'

const Icon = ({ children, ...rest }) => <div {...rest}>{children}</div>

const Title = ({ children, ...rest }) => <div {...rest}>{children}</div>

function Header({ children }) {
  const titles = React.Children.toArray(children).filter(
    (child) => child.type === Title
  )
  const icons = React.Children.toArray(children).filter(
    (child) => child.type === Icon
  )

  return (
    <div>
      <div className="icons">{icons}</div>
      <div className="title">{titles}</div>
      <a href="www.google.com">Google</a>
    </div>
  )
}

Header.Title = Title
Header.Icon = Icon
export { Header }
