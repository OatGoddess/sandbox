import './App.css'
import { Header } from './header'

window.addEventListener('beforeunload', function (e) {
  // Cancel the event
  e.preventDefault() // If you prevent default behavior in Mozilla Firefox prompt will always be shown
  // Chrome requires returnValue to be set
  e.returnValue = ''
})

function App() {
  return (
    <Header>
      <Header.Icon>
        <div>icon</div>
      </Header.Icon>
      <Header.Title>
        <b>Hello world</b>
      </Header.Title>
    </Header>
  )
}

export default App
