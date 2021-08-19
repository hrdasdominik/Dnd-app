import PropTypes from 'prop-types'

const Header = ({ title }) => {
    return (
        <div className='header'>
            <h1>{title}</h1>
        </div>
    )
}

Header.defaultProps = {
    title: 'Dungeons and Dragons',
}

Header.propTypes = {
    title: PropTypes.string,
}

export default Header

/*
return fetch("https://localhost:5001/api/CharacterSheets")
      .then((response) => response.json())
      .then((data) => console.log(data));
*/